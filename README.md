# MarketEnfey

## Hi! This is just a quick guide to whats going on in this monolithic mess that is the beating heart of my coursework (if you're a stranger, ignore how much of a mess this is, i wrote 90% of it when i had no clue what i was doing) <br>

There are 16 forms in total but only some forms leverage the power of the OleDb update classes and methods. These are as follows:<br>

1. ***Customers***: Updating and adding customers.
2. ***Employees***: Updating and adding employees.
3. ***Orders*** :Updating and adding orders, and to update a relevant **'receiptsent'** field for a given customer when a receipt is sent.
4. ***Forgotten password***, for resetting passwords (functionality is slightly different here and hasnt been refactored yet, but this make no difference.)

Out of these forms, all of them are able to read data into local data structures etc. But as we saw earlier today, these changes are committed, the file size of the temporary file changed, thus receiving the SQL command and parsing it, yet having no effect on the data stored in the database.

Here is a brief list of things considering in terms of rectifying this issue:
1. Wrapping update as a transaction and force committing it to the database
2. Reverting to the initial implementation, which was used to test with, and should work. This includes the removal of **'using'** etc.
3. GetUpdateCommand method of the command builder class. See below
![image](https://user-images.githubusercontent.com/42583186/224802775-3cf012e1-5c97-4d22-b79b-1d2b7202b26f.png)
4. Changing back relative paths to fixed file location paths
![image](https://user-images.githubusercontent.com/42583186/224802873-df5e5b47-e604-4a63-8860-3c70d4f16266.png) <br>
to:
![image](https://user-images.githubusercontent.com/42583186/224803139-4fa28ea1-1549-4bb0-a662-bd1b1d8af143.png)


5. An update function with a more general logic, to be reused across all of these forms. Had the exact same issue with this, function completes, but no update is made.

I did try a few more things but i genuinely cannot remember what i did (it'll come to me)

My next planned fix is to create a sep table, and try to mess with that (0 relationships).<br>
If that fails to work, i'm going to create a new database, and see if the issue is isolated to the external processing occurring in access.<br>
If all else fails, i'll just create a new VS project, and make sure i dont miss anything when programming it.<br>

A quick final note, you'll have to make edits to just boot up main menu after successful login (especially to avoid the captcha), since twilio won't be able to send to your number, and your email isn't in the db either. <br>

Feel free to email or talk to me about this or submit pull requests!<br>
Thanks!


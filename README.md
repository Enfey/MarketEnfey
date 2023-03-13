# MarketEnfey

## Hi! This is just a quick guide to whats going on in this monolithic mess that is the beating heart of my coursework <br>

There are 16 forms in total but only forms leverage the power of the OleDb update stuff. These are as follows:<br>

1. Customers, for updating and adding customers
2. Employees, for updating and adding employees 
3. Orders, for updating and adding orders, and to update a relevant **'receiptsent'** field when a receipt is sent (although that SQL is a bit dodgy, wouldnt bother going there)
4. Forgotten password, for resetting passwords (functionality is slightly different here and hasnt been refactored yet, but still doesnt work for me)

Out of these forms, all of them are able to read data into local data structures etc. But as we saw earlier today, these changes are committed, the file size of the temporary file changed, thus receiving the SQL command and parsing it, yet having no effect on the data stored in the database.

Here is a brief list of things considering in terms of rectifying this issue:
1. Wrapping update as a transaction and force committing it to the database
2. Reverting to the initial implementation, which was used to test with, and should work. This includes the removal of using keywords, as well as only using one, class wide dataAdapter etc
3. cd.getupdate command
4. changing back relative paths to fixed paths
5. An update function with a more general logic, to be reused across all of these forms. Had the exact same issue with this, function completes, but no update is made.

I did try a few more things but i genuinely cannot remember what i did.

My next planned fix is to create a sep table, and try to mess with that (0 relations). If that fails to work, i'm going to create a new database, and see if the issue is isolated to the external processing occurring in access.
If all else fails, i'll just create a new VS project, and make sure i dont miss anything when programming it.

Feel free to email or talk to me about this or submit prs!
Thanks!


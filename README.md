# Bartender
bartender app for cis4327

----------------------------------------------------------------
LOGIN INFO

When logging into the program, use one of the following users:
Staff:
User: gaskillcw
Pass: test

Customer:
User: sacarali
Pass: test

----------------------------------------------------------------
STRUCTURAL FLOW

Roles for the application are defined as either Staff or Customer. 
Staff users may access both Staff and Customer portals, 
whereas Customer users may only access the Customer portal.

When the Customer portal is accessed, the list of drinks stored
in the repository file are shown in a table with a button for
customers to order the corresponding drink.
When that button is pressed, that drink's information is stored 
in a newly created Order object and sent to the list of orders
in the repository file.

In the Staff portal, the list of orders from the repository file
is displayed. A Staff user is then able to press the button beside
the corresponding order they wish to fulfill, which will remove the
order from the list of orders in the repository.




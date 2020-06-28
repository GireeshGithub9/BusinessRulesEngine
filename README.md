# BusinessRulesEngine
Process business order
Takes user input such as 1. Emial ID, 2. Order Type, 3. Agent details
Handles any input validations
Throws exception if user input is not valid
Based on Order Type input process the order and return desired output

Solution is having 2 Layer 
1. Business Layer
   Logic for handling all type of Orders dynamically based on user inputs 
   implemented OOPS concepts like Polymorphism, Inheritense and used Abstract class as a base class and inherited other classes from this base classNow Business layer become more re-usable & modular
2. User Interface
   Here used Console application as a client and consumed Business layer,

Execution:

To execute this application supply inputs in Arguments as below 

1. --email girish@gmail.com --order-type BOOK --agent Gireesh
2. --email girish@gmail.com --order-type PHYSICAL_PRODUCT --agent Gireesh
3. --email girish@gmail.com --order-type NEW_MEMBERSHIP --agent Gireesh
4. --email girish@gmail.com --order-type UPGRADE_MEMBERSHIP --agent Gireesh
5. --email girish@gmail.com --order-type LEARNING_TO_SKI --agent Gireesh



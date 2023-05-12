# Split Email Task

This is C# code that reads a list of email addresses from a file, groups them by domain name, and outputs the number of email addresses for each domain, along with the email addresses themselves.

The code starts by defining two classes, my_form and my_form2, which have properties for domain, email, and count. Then it defines a Main method, which prompts the user to enter a variant number, reads the list of email addresses from a file named "list_email.txt", and stores them in a List<my_form> object called My_email_List.

If the user enters "1", the code proceeds to group the email addresses by domain name using LINQ syntax. The group by clause groups the email addresses by domain, and the select clause creates a new object with properties for the domain name and the count of email addresses in that group. The resulting collection is sorted in descending order by the count.

Finally, the code loops through the groups and outputs the domain name and count, followed by the email addresses in that group, sorted alphabetically.

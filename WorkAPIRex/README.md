# WorkAPIRex Task:

This code obtains the current USD exchange rate at PrivatBank from its API using the HttpClient library. The URL of the API endpoint is stored in the 'url' variable, which is used to send a request.

After the response is received, the content is stored in the 'html' variable as a string. Then, a regular expression is used to find a string that contains information about the USD exchange rate, which includes the substring ""ccy":"USD"". If the regular expression finds a match, the values of the buy and sale rates are extracted and printed to the console. If the regular expression doesn't find a match, the message "Data for USD not found." is displayed.


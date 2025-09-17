# A converter for international currency exchange.
USD_to_GBP = 0.73       # Today's rate, US dollars to British Pounds
USD_to_EUR = 0.84       # Today's rate, US dollars to Euros
USD_to_JPY = 146.00     # Today's rate, US dollars to Japanese Yen
USD_to_INR = 87.84      # Today's rate, US dollars to Indian Rupees
USD_to_CZK = 20.55      # Today's rate, US dollars to Czech Crowns

GBP_sign = '£'     # Unicode values for non-ASCII currency
EUR_sign = '€'     # symbols.
JPY_sign = '₹'
INR_sign = '¥'
CZK_sign = "Kč"

dollars = 1000          # The number of dollars to convert

pounds = dollars * USD_to_GBP
euros = dollars * USD_to_EUR
yen = dollars * USD_to_JPY
rupees = dollars * USD_to_INR
crowns = dollars * USD_to_CZK

print('Today, $' + str(dollars))    # Printing the results
print('converts to ' + GBP_sign + str(pounds))
print('converts to ' + EUR_sign + str(euros))
print('converts to ' + JPY_sign + str(yen))
print('converts to ' + INR_sign + str(rupees))
print('converts to ' + str(crowns) + CZK_sign) 
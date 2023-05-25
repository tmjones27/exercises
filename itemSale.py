# program determines prices for items at 10% off
# #############################
print('Sales Calculator\n')

x = float(.10) #10% off
y = float(.01) #.01 cent
yes = 'y'

#lists
items = []
values = []

while yes == 'y':
    try:
        name = input('Enter item name: ')
        price = round(float(input('Enter item price: $')),2)
    except ValueError:
        print('Sorry. Try again.\n')
    else:
        items.append(name)
        decr = price - (price * x)  # decrease prod price
        rnd = int(decr + 0.5)  # round value
        sale = rnd - y  # subtract by .01 cent
        if sale < price and sale > 0:
            print("""\nHere's the sale price of""" ," " ,name ,': $' ,format(sale, ',.2f'), '\nYou are saving $' ,format(price - sale, ',.2f') ,' on each purchase.',sep='')
            values.append(sale)
            yes = input('\nDo you want to enter another item? (y/n): ').lower()
        elif sale > price:
            print("""Here's the sale price: $""" ,format(sale, ',.2f'), sep='')
            print('\nSorry, sale price is not cost effective.\nYou are losing: $' ,format(sale - price,',.2f') ,' on each purchase.')
            values.append(price)
            yes = input('\nDo you want to enter another item? (y/n): ').lower()
        elif sale == price:
            print("""Here's the sale price: $""", format(sale, ',.2f'), sep='')
            print('\nSale price is same as item price.', sep='')
            values.append(price)
            yes = input('\nDo you want to enter another item? (y/n): ').lower()
        elif sale <= 0:
            print('Sorry. That item price calculated a negative value of: $' ,format(sale, ',.2f'), sep='')
            values.append(price)
            yes = input('\nDo you want to enter another item? (y/n): ').lower()
        else:
            break

print("""\nHere's a list of the items you've entered and the best price for that item:""")
for name, price in zip(items, values):
    print('  ' ,name, '\t  $' ,format(price ,',.2f'),sep='')

print('\nHappy Shopping!')








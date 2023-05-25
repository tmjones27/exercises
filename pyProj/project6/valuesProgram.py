# program reads values stored in gas, dining and lodging files and should adequately handle 
# errors if files aren't found. 
# ##########################################################
def main():
    # values
    gval = gas()
    lval = lodging()
    dval = dining()

    # averages
    gavg = avg_gas(gval)
    lavg = avg_lodging(lval)
    davg = avg_dining(dval)

    print('\n      Report:')
    if gval is None or gavg is None: # gas output
        print('Gas value is Null.')
    else:
        print('Total Gas: $', format(max(gval), ',.2f'),
              '\nAverage Gas: $', format(gavg, ',.2f'), sep='')

    if lval is None or lavg is None: # lodging output
        print('\nLodging value is Null.')
    else:
        print('\nTotal Lodging: $', format(max(lval), ',.2f'),
              '\nAverage Lodging: $', format(lavg, ',.2f'), sep='')

    if dval is None or davg is None: #dining output
        print('\nDining value is Null.')
    else:
        print('\nTotal Dining: $', format(max(dval), ',.2f'),
              '\nAverage Dining: $', format(davg, ',.2f'), sep='')

    if gval is None and lval is None and dval is None:
        pass
    elif gval is None and lval is None:
        pass
    elif gval is None and dval is None:
        pass
    elif lval is None and dval is None:
        pass
    elif gval is None:
        print('\nGrand Total: $', format(max(lval) + max(dval), ',.2f'), sep='')
    elif dval is None:
        print('\nGrand Total: $', format(max(gval) + max(lval), ',.2f'), sep='')
    elif lval is None:
        print('\nGrand Total: $', format(max(gval) + max(dval), ',.2f'), sep='')
    else:
        print('\nGrand Total: $', format(max(gval) + max(lval) + max(dval), ',.2f'), sep='')

def gas():
    try:
        gas_file = open('gas.txt', 'r')
        gas_txt = gas_file.readline()
        total1 = 0.0  # gas total
        gval = []  # gas values
        while gas_txt != '':
            gas = float(gas_txt)
            gas_txt = gas_file.readline()
            total1 += gas
            gval.append(total1)
        return gval
    except IOError as err:
        print(err)
        gval = None
        return gval

def avg_gas(gval): # average for gas
    if gval is None:
        pass
    else:
        gavg = max(gval) / len(gval)
        return gavg

def lodging():
    try:
        lodging_file = open('lodging.txt', 'r')
        lodging_txt = lodging_file.readline()
        total2 = 0.0  # lodging total
        lval = []  # lodging values
        while lodging_txt != '':
            lodging = float(lodging_txt)
            lodging_txt = lodging_file.readline()
            total2 += lodging
            lval.append(total2)
        return lval
    except IOError as err2:
        print(err2)
        lval = None
        return lval

def avg_lodging(lval): # average for lodging
    if lval is None:
        pass
    else:
        lavg = max(lval) / len(lval)
        return lavg

def dining():
    try:
        dining_file = open('dining.txt', 'r')
        dining_txt = dining_file.readline()
        total3 = 0.0  # dining total
        dval = []  # dining values
        while dining_txt != '':
            dining = float(dining_txt)
            dining_txt = dining_file.readline()
            total3 += dining
            dval.append(total3)
        return dval
    except IOError as err:
        print(err)
        dval = None
        return dval

def avg_dining(dval): # average for dining
    if dval is None:
        pass
    else:
        davg = max(dval) / len(dval)
        return davg

main()
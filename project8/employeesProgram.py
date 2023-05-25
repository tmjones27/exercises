# program reads values from employeesAQYX-1.txt found in same directory
# ##########################################################
def main():
    employees_dict = {}
    emp_dict = {} # legend
    with open('employeesAQYX-1.txt', 'r') as file1:

        for line in file1:
            key = line.strip()
            value = file1.readline().strip()
            value2 = file1.readline().strip()
            value3 = file1.readline().strip()

            employees_dict[key] = value, value2, value3
            emp_dict[key] = ()

    print(emp_dict)
    loop = 'y'

    while loop == 'y':
        x = input("\n\n\t   Employee Search\n(Enter 'Q' at anytime to quit.)\nEnter the employee's last name: ")
        if x in employees_dict:
            print('\nPress (0) for First Name or (1) for Phone Extension or (2) for Department Code.')
            i = input('What would you like to view?: ')
            if i == str('0'):
                print('\nFirst Name: ', end='')
                for x in employees_dict[x][0]:
                    print(x, end="")
            elif i == str('1'):
                print('\nPhone Ext.: ', end='')
                for x in employees_dict[x][1]:
                    print(x, end="")
            elif i == str('2'):
                print('\nDept. Code: ', end='')
                for x in employees_dict[x][2]:
                    print(x, end="")
            elif i == 'q':
                print('')
                y = input('Are you sure? (y/n): ').lower()
                if y != 'y':
                    continue
                else:
                    break
            else:
                print('\nInput Error.')
                y = input('Do you want to try again? (y/n): ').lower()
                if y != 'n':
                    break
        elif x == 'q' or x == 'Q':
            break
        else:
            print('\nSorry. Last name not found in system.')
            y = input('Do you wish to enter another employee? (y/n): ').lower()
            if y != 'y':
                break
main()
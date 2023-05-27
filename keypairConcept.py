# example of diffie-hellman protocol for exchanging information over a public channel. shared secret should be the same 
# despite not knowing the private key value.  

import random

def main():
    x = random.randint(1,100) # control
    p = find_prime()

    if p == 0:
        main()
    else: 
        cpu_a(x, p)
        cpu_b(x, p)
        priv_key_a, pub_key_a = cpu_a(x, p)
        priv_key_b, pub_key_b = cpu_b(x, p)
        cpu_shared_secret_a(priv_key_a, pub_key_b, p)
        cpu_shared_secret_b(priv_key_b, pub_key_a, p)

# determine if prime number
def find_prime():
    n = random.randint(200,2000)
    factors = []
    for i in range(1, 2001):
        if (n % i == 0):
            factors.append(i)
    if len(factors) != 1 and len(factors) <= 2:
        return n
    else:
        n = 0
        return n

# computer a, generate public-private key pair
def cpu_a(rand_num, prime):
    # private key value
    priv_key_a = random.randint(1,100) 
    # create public key value
    pub_key_a = (rand_num^priv_key_a) % prime

    return priv_key_a, pub_key_a

def cpu_shared_secret_a(priv_key_a, pub_key_b, p):
    #shared secret value
    shared_secret_a = (priv_key_a^pub_key_b) % p

    return print(f'Shared secrect for A is: {shared_secret_a}')

# computer b, generate public-private key pair
def cpu_b(rand_num, prime):
    # private key value
    priv_key_b = random.randint(1,100)
    # create public key value
    pub_key_b = (rand_num^priv_key_b) % prime

    return priv_key_b, pub_key_b

def cpu_shared_secret_b(priv_key_b, pub_key_a, p):
    # shared secret value
    shared_secret_b = (priv_key_b^pub_key_a) % p

    return print(f'Shared secrect for B is: {shared_secret_b}')

main()




     


        


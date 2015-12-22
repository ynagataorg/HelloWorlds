# coding: UTF-8
from datetime import datetime

def fact(n):
    if not(isinstance(n, int)):
        raise ValueError("fact には引数として 0 以上の整数を与えてください。")
    if (n < 0):
        raise ValueError("fact には引数として 0 以上の整数を与えてください。")
    if (n == 0):
        return 1
    else:
        return n * fact(n - 1)

if __name__ == '__main__':
    print 'Hello, World! @ {0}'.format(datetime.now().strftime("%Y/%m/%d %H:%M:%S"))
    print '5! = {0}'.format(fact(5))

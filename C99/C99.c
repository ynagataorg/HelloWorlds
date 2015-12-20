#include <stdio.h>
#include <time.h>

unsigned int fact(unsigned int n)
{
    int ret;
    if (n == 0)
    {
        ret = 1;
    }
    else
    {
        ret = n * fact(n - 1);
    }
    return ret;
}

int main(void)
{
    time_t timer;
    struct tm *local;
    timer = time(NULL);
    local = localtime(&timer);
    printf("Hello, World! @ %04d/%02d/%02d %02d:%02d:%02d\n",
        local->tm_year + 1900, local->tm_mon + 1, local->tm_mday,
        local->tm_hour, local->tm_min, local->tm_sec);

    printf("fact(5) == %d\n", fact(5));
}

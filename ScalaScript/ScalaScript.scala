import java.util.Date
var datestr = "%tY/%<tm/%<td %<tT" format new Date

def fact(n: Int): Int = if (n <= 1) 1 else n * fact(n - 1)

println("Hello, world! @ " + datestr)
println("fact(5) == " + fact(5))


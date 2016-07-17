import scala.annotation.tailrec
import java.util.Date
var datestr = "%tY/%<tm/%<td %<tT" format new Date

def fact(n: Int): Int = {
  @tailrec
  def factIter(prod: Int, n: Int): Int =
    if (n == 1) prod else factIter(prod * n, n - 1)
  if (n <= 1) 1 else factIter(1, n)
}

println("Hello, world! @ " + datestr)
println("fact(5) == " + fact(5))


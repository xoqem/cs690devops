namespace FactorialLibrary;
public class FactorialService
{
  public static int Factorial(int n) {
    if(n==1 || n==0) {
      return 1;
    }
    return n * Factorial(n-1);
  }
}

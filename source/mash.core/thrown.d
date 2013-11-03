module thrown;

class Base : Throwable
{
  this()
  {
    super("");
  }

  this(string msg, Throwable next = null)
  {
    super(msg, next);
  }

  this(string msg, string file, size_t line, Throwable next = null)
  {
    super(msg, file, line, next);
  }
}

class InvalidArgumentException : Base
{
}
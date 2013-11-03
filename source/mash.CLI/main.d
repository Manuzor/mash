module main;

import std.stdio;

int main(string[] argv)
{
  string input;
  string inputPrefix = "$ ";

  stdout.write(inputPrefix);
  foreach(line; stdin.readln())
  {
    stdout.writeln(line);
    stdout.write(inputPrefix);
  }

  return 0;
}

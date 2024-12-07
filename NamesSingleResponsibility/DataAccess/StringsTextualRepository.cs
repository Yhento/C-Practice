global using System.Diagnostics;
using System;

namespace NamesSingleReponsibility.DataAccess;

class StringsTextualRepository
{
  private static readonly string Separator2 = Environment.NewLine;
  public List<string> Read(string filePath)
  {
    var fileContents = File.ReadAllText(filePath);
    return fileContents.Split(Environment.NewLine).ToList();

  }

  public void Write(string filePath, List<string> strings)
  {
    File.WriteAllText(filePath, string.Join(Environment.NewLine, strings));
  }

}

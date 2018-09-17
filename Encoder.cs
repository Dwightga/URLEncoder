using System;

namespace UrlEncoder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                if (int x = 1)
                {



                    Console.WriteLine("What is the Project name that you would like to use for your URL?");
                    string Project = Console.ReadLine();

                    foreach (char c in Project)
                    {
                        if ((int)c > 127)
                            continue;
                        if ((int)c < 32)
                            continue;
                        if (c == ',')
                            continue;
                        if (c == '"')
                            continue;
                        break;
                        Console.WriteLine("Name not valid. Please re-enter proper Project name");
                        Project = Console.ReadLine();
                        Console.WriteLine(c);

                    }


                    Console.WriteLine("What is the Activity name that you would like to use for your URL?");
                    string Activity = Console.ReadLine();

                    foreach (char c in Activity)
                    {
                        if ((int)c > 127)
                            continue;
                        if ((int)c < 32)
                            continue;
                        if (c == ',')
                            continue;
                        if (c == '"')
                            continue;
                        break;
                        Console.WriteLine("Name not valid. Please re-enter proper Activity name");
                        Project = Console.ReadLine();
                        Console.WriteLine(c);

                    }
                    Console.WriteLine("Project Name:" + Project);
                    Console.WriteLine("Activity Name:" + Activity);
                    Console.WriteLine("Result Url:");
                    string Url = "http://companyserver.com/content/" + Project + "/files/" + Activity + "/" + Activity + "Report.pdf";

                    var replacement = Url.Replace(" ", "%20").Replace("<", "%3c").Replace(">", "%3E").Replace("#", "%23").Replace("%", "%25").Replace(";", "%3B").Replace("?", "%3F")mm.Replace("@", "%40")
                                         .Replace("&", "%26").Replace("=", "%3D").Replace("+", "%2B").Replace("$", "%24").Replace(",", "%2C")
                                         .Replace("{", "%7B").Replace("}", "%7D").Replace("|", "%7C").Replace("^", "%5E").Replace("[", "%5B").Replace("]", "%5D").Replace("'", "%60");
                    Console.WriteLine(replacement);
                }
                    else
                    {
                        done = true;

                    }

            }
        }
    }
}

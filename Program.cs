class reginit 


{
    public static void Writer(String s) 
    {
    
        Console.WriteLine(s);
    
    
    }
    public static void lists(String[] ss) 
    {
        foreach (String s in ss) 
        { 
            Writer(s);
        
        
        
        }
    
    
    
    }
    public static void save(String[] ss,String files)

    {
        String Value = "";
        String v = "";
        foreach (String s in ss)
        {
            v = s.Replace("=", "\x02");
            Value=Value+v+"\x01";



        }
        File.WriteAllText(files, Value);


    }
    public static String[] Splint(String s ) 
    
    {
        String[] ss = s.Split("\n");
        return ss;
    
    }



}




class regfiles 

{
    static String resource1 = "main/main=main\n"+
                       "main/system=system\n"+
                       "main/x=xxx\n"+
                       "system/main=mene\n"+
                       "system/system=main\n";


    public static void Main() 
    
    {
        String[] ss = reginit.Splint(resource1);


        Console.BackgroundColor=ConsoleColor.White;
        Console.ForegroundColor=ConsoleColor.Black;
        Console.Clear();
        reginit.lists(ss);
        reginit.save(ss, "hello.dat");
    
    
    
    }






}


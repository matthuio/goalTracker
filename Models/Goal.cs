public class Goal()
{
    public int Id {get;set;}
    public String ?Title{get;set;}
    public String ?Desc {get;set;}
    public List<Goal> ?Steps {get;set;}
    public String ?CompleteCondition {get;set;}
    public int ?Progress {get;set;} = 0;
}
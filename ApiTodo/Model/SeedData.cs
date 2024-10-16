public class SeedData
{
    public static void Init(TodoContext context)
    {


context.Todos.Add(new Todo {Task = "ranger vaisselle",Completed = true});
context.Todos.Add(new Todo {Task = "gagner sur valo",Completed = false, Deadline = DateTime.Today});
context.Todos.Add(new Todo {Task = "perdre sur JD", Completed = false});


}
}
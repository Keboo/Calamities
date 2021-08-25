class Task
{
    public static Task CompletedTask => new Task();
    
    public static int InstanceCount { get; set; }
    public Task()
    {
        InstanceCount++;
    }
}

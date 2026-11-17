class Task
{
    public static Task CompletedTask => new();
    
    public static int InstanceCount { get; set; }
    public Task()
    {
        InstanceCount++;
    }
}

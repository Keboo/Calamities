using System;
using System.Runtime.CompilerServices;

static class TaskExtensions
{
    public static TaskAwaiter GetAwaiter(this Task awaitable) => new(Task.InstanceCount == 2);
    
    public class TaskAwaiter : INotifyCompletion
    {
        public TaskAwaiter(bool eraseBob)
        {
            EraseBob = eraseBob;
        }

        public bool IsCompleted { get; set; } = true;
        public bool EraseBob { get; }

        public void OnCompleted(Action continuation)
            => throw new NotImplementedException();

        public void GetResult()
        {
            //Ensure string used in var.ToString() is initialized and interned
            _ = new var().ToString();

            if (EraseBob)
            {
                const string name = "Bob";
                const string newName = "Joe";

                unsafe
                {
                    fixed (char* ptr = name)
                    {
                        for (int i = 0; i < name.Length; i++)
                        {
                            ptr[i] = newName[i];
                        }
                    }
                }
            }
        }
    }

}

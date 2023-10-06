# Async Task

```
❯ dotnet run TaskInstantiation    
                                                                             
Task=1, obj=beta, Thread=4
t1 has beed launched. (Main Thread=1)
Task=2, obj=alpha, Thread=6
Task=3, obj=delta, Thread=6
Task=4, obj=gamma, Thread=1
```

```
❯ dotnet run Waiting

taskA Status: WaitingToRun
taskA Status: RanToCompletion
```

```
❯ dotnet run WaitingAll   

Status of completed tasks:
   Task #1: RanToCompletion
   Task #2: RanToCompletion
   Task #3: RanToCompletion
   Task #4: RanToCompletion
   Task #5: RanToCompletion
   Task #6: RanToCompletion
   Task #7: RanToCompletion
   Task #8: RanToCompletion
   Task #9: RanToCompletion
   Task #10: RanToCompletion
```

```

❯ dotnet run Cancellation    
                               
One or more exceptions occurred:
   TaskCanceledException: A task was canceled.
   NotSupportedException: Specified method is not supported.
   TaskCanceledException: A task was canceled.
   TaskCanceledException: A task was canceled.
   NotSupportedException: Specified method is not supported.
   TaskCanceledException: A task was canceled.
   TaskCanceledException: A task was canceled.
   NotSupportedException: Specified method is not supported.
   TaskCanceledException: A task was canceled.

Status of tasks:
   Task #1: RanToCompletion
   Task #2: Canceled
   Task #3: Faulted
   NotSupportedException: Specified method is not supported.
   Task #4: Canceled
   Task #5: RanToCompletion
   Task #6: Canceled
   Task #7: Faulted
   NotSupportedException: Specified method is not supported.
   Task #8: Canceled
   Task #9: RanToCompletion
   Task #10: Canceled
   Task #11: Faulted
   NotSupportedException: Specified method is not supported.
   Task #12: Canceled
```
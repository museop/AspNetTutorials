# Sync logic vs Async logic

```bash
❯ dotnet run                 
                                               
Program Begin (Sync)
1 - Starting
2 - Task started
A - Started something
B - Completed something
3 - Task completed with result: 123
Program End (Sync)

Program Begin (Async)
1 - Starting
2 - Task started
A - Started something
Program End (Async)
B - Completed something
3 - Task completed with result: 123
```
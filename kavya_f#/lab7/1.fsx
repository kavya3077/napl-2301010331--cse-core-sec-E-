open System
open System.Diagnostics

// Simulates an I/O-bound task using Async.Sleep
let task (name: string) (delay: int) : Async<string> =
    async {
        printfn "%s started  (%s)" name (DateTime.Now.ToString("HH:mm:ss.fff"))
        do! Async.Sleep delay
        printfn "%s finished (%s)" name (DateTime.Now.ToString("HH:mm:ss.fff"))
        return sprintf "%s completed successfully" name
    }

let main () =
    printfn "Starting Parallel Workflows..."
    printfn ""

    let stopwatch = Stopwatch.StartNew()

    // Run all three tasks concurrently and wait for all results
    let results =
        [ task "Task 1" 1000
          task "Task 2" 3000
          task "Task 3" 2000 ]
        |> Async.Parallel
        |> Async.RunSynchronously

    stopwatch.Stop()

    printfn ""
    printfn "All Tasks Completed!"
    printfn ""
    printfn "Final Results:"
    results |> Array.iter (printfn "%s")

    printfn ""
    printfn "Total time: %d ms" stopwatch.ElapsedMilliseconds
    printfn "(Sequential execution would have taken about 6000 ms)"

main ()

// NOTE: If warnings appear, you may need to retarget this project to .NET 4.0. Show the Solution
// Pad, right-click on the project node, choose 'Options --> Build --> General' and change the target
// framework to .NET 4.0 or .NET 4.5.

module CoreUtilies.Common
    let DigitsToArray n = Seq.unfold (fun i -> 
        if i = 0I then 
            None 
        else 
            Some(i%10I, i/10I)) n

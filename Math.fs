module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let f (n : int64) =
  if n % 2L = 0L then n / 2L
  else 3L * n + 1L

let collatz n =
  let rec iter cnt (n : int64) = 
    let result = f n
    if result = 1L then cnt
    else iter (cnt + 1) result
  iter 1 n
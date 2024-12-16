let mutable x = 1
let y = ref x
!y <- 2
printf "%d %d" x (!y)
// Explanation: Using ref creates a proper reference.  The original mutable variable is correctly updated.
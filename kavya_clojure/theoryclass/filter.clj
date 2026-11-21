; filter -- it apples a predicate function to each element of a collection and returns a lazy sequence of the items for which the predicate returns true.
; we use precidate functions to filter out elements from a collection based on certain conditions.
(println (filter even? [1 2 3 4 5 6]))

(println (filter odd? [1 2 3 4 5 6]))

(println (filter #(> % 3) [1 2 3 4 5 6 7]))

(println (filter string? [1 "hello" 2 "world" 3]))


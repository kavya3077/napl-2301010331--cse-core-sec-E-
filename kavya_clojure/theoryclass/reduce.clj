; reduce -- it applies a function cumulatively to the items of a collection, from left to right, so as to reduce the collection to a single value.
(println (reduce + [1 2 3 4 5])) ; => 15
(println (reduce * [1 2 3 4 5])) ; => 120

(println max[3 1 4 1 5 9]) ; => 9

; with an initial value
(println (reduce + 100 [1 2 3 4 5])) ; => 115

; build a custom reduce
(println (reduce str [1 2 3 4 5])) ; => "12345"


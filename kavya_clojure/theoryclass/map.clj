;map function
(println (map inc [1 2 3 4 5])) ; => (2 3 4 5 6)
(println (map #(* 2 %) [1 2 3 4 5])) ; => (2 4 6 8 10)
(println (map str [1 2 3 4 5])) ; => ("1" "2" "3" "4" "5")

; map with multiple collections
(println (map + [1 2 3] [6 5 4])) ; => (7 7 7)


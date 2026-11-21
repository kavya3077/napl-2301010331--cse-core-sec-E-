; map + basic + filter pipeline

; Thread first macro
; The value of the first expression is passed as the first argument to the next expression.

(println (-> [1 2 3 4 5 6]
             (filter even?)
             (map inc)
             (reduce +))) ; => 12


; Thread last macro
; The value of the first expression is passed as the last argument to the next expression.

(println (->> [1 2 3 4 5 6]
              (filter even?) ; step 1: keep evens - (2 4 6)
              (map #(* % %)) ; step 2: square each element - (4 16 36)
              (reduce +))) ; step 3: sum the elements - 56
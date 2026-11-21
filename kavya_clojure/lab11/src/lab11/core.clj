(ns lab11.core
  (:gen-class))

(defn -main
  "I don't do a whole lot ... yet."
  [& args]
  ; First Collection
  (println "----- FIRST COLLECTION -----")

  (def numbers [3 5 7 9 11])

  (println "Original Collection:" numbers)

  ; map
  (println "Squares:" (map #(* % %) numbers))

  ; filter
  (println "Numbers Greater Than 5:"
    (filter #(> % 5) numbers))

  ; reduce
  (println "Product:" (reduce * numbers))

  ; take and drop
  (println "Take 2:" (take 2 numbers))
  (println "Drop 3:" (drop 3 numbers))

  ; Threading Macro
  (println "Threading Result:"
    (->> numbers
         (filter odd?)
         (map #(+ % 1))))


  ; Second Collection
  (println "\n----- SECOND COLLECTION -----")

  (def prices '(100 200 300 400 500))

  (println "Original Collection:" prices)

  ; map
  (println "Discounted Prices:" (map #(- % 20) prices))

  ; filter
  (println "Prices Above 250:"
    (filter #(> % 250) prices))

  ; reduce
  (println "Maximum Price:" (reduce max prices))

  ; take and drop
  (println "Take 3:" (take 3 prices))
  (println "Drop 2:" (drop 2 prices))

  ; Threading Macro
  (println "Threading Result:"
    (->> prices
         (filter #(> % 200))
         (take 2)))
)

(ns lab11-1.core
  (:gen-class))

(defn -main
  "I don't do a whole lot ... yet."
  [& args]
    ; 1. Static Methods
  (println "1. Static Methods")

  (println "Absolute Value:" (Math/abs -35))
  (println "Maximum Number:" (Math/max 12 28)


  ; 2. ArrayList
  (println "\n2. ArrayList")

  (def fruits (java.util.ArrayList.))

  (.add fruits "Apple")
  (.add fruits "Orange")
  (.add fruits "Mango")

  (println "Fruits:" (seq fruits))
  (println "First Fruit:" (.get fruits 0))
  (println "Total Fruits:" (.size fruits))


  ; 3. HashMap
  (println "\n3. HashMap")

  (def student (java.util.HashMap.))

  (.put student "Name" "Riya")
  (.put student "RollNo" 105)

  (println "Student Details:" (into {} student))
  (println "Student Name:" (.get student "Name"))


  ; 4. Collection Conversion
  (println "\n4. Collection Conversion")

  (def numbers [10 20 30 40])

  (def java-numbers (java.util.ArrayList. numbers))

  (println "Clojure Vector:" numbers)
  (println "Java ArrayList:" (seq java-numbers))

  (def clojure-numbers (vec java-numbers))

  (println "Converted Back:" clojure-numbers)
)
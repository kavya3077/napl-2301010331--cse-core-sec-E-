(ns lab10.core
  (:gen-class))

(defn -main
  "I don't do a whole lot ... yet."
  [& args]
 
   (def my-list '(50 60 70))
 
   (println "Original List:" my-list)
   (println "First:" (first my-list))
   (println "Rest:" (rest my-list))
 
   (def list2 (conj my-list 5))
 
   (println "After conj:" list2)
   (println "Original List:" my-list)
 
 
   ; 2. Vector
   (println "\n -------------------")
 
   (def my-vector [50 60 70])
 
   (println "Original Vector:" my-vector)
 
   (def vector2 (conj my-vector 80))
 
   (println "After conj:" vector2)
   (println "Get index 1:" (get my-vector 1))
   (println "Count:" (count my-vector))
   (println "Original Vector:" my-vector)
 
 
   ; 3. Map
  (println "\n -------------------")
 
   (def my-map {:name "Kavya Mudgil" :age 22})
 
   (println "Original Map:" my-map)
 
   (def map2 (assoc my-map :city "New Delhi"))
 
   (println "After assoc:" map2)
   (println "Get name:" (get my-map :name))
 
   (def map3 (dissoc my-map :age))
 
   (println "After dissoc:" map3)
   (println "Original Map:" my-map)
 
 
   ; 4. Set
   (println "\n -------------------")
 
   (def my-set #{40 50 60 70})
 
   (println "Original Set:" my-set)
 
   (def set2 (conj my-set 80))
 
   (println "After conj:" set2)
 
   (def set3 (disj my-set 20))
 
   (println "After disj:" set3)
   (println "Contains 10:" (contains? my-set 10))
   (println "Original Set:" my-set)
 )
 
 
 
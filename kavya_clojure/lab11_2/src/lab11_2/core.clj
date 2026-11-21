(ns lab11-2.core)

;; custom exception using ex-info
(defn withdraw [balance amount]
  (if (> amount balance)
    (throw (ex-info "Insufficient balance"
                    {:balance balance :amount amount}))
    (- balance amount)))

;; exception handling
(defn test-it [f]
  (try
    (println "Result:" (f))
    (catch ArithmeticException e
      (println "Cannot divide by zero"))
    (catch NullPointerException e
      (println "Value is null"))
    (catch clojure.lang.ExceptionInfo e
      (println "Error:" (ex-message e))
      (println "Data:" (ex-data e))
      (println "Please enter amount less than or equal to"
               (:balance (ex-data e))))
    (finally
      (println "Finally block run hua\n"))))

(defn -main [& args]
  (test-it #(/ 100 0))          ; ArithmeticException
  (test-it #(.length nil))      ; NullPointerException
  (test-it #(withdraw 500 800)) ; custom ex-info
  (test-it #(withdraw 500 200)))  ; success
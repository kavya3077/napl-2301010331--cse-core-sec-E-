
; try/catch -- error handling
; Exception handling is used to handle runtime errors in a program.
; try contains code that may cause an error.
; catch handles the exception if an error occurs.
; ArithmeticException handles arithmetic errors like division by zero.
; nil represents no value.


(def result
  (try
    (/ 10 2)
    (catch ArithmeticException e
      (println "Error: Division by zero" (.getMessage e))
      0)))


; imppppp
(defn safe-divide [a b]
  (try
    (/ a b)
    (catch ArithmeticException e
      (println "Error: Division by zero")
      nil)))


(safe-divide 10 2) ; => 5
(safe-divide 10 0) ; => nil, prints "Error: Division by zero"


; testing -- filename_test.clj
; what is testing? Testing is the process of evaluating a program to ensure that it behaves as expected. It helps identify bugs and verify that the code meets its requirements.
; two deftest case sqare and add
(deftest test-square
  (is (= 25 (square 5))) ; -> 25
  (is (= 100 (square -10)))) ; -> 100

(deftest test-add
  (testing "positive numbers"
    (is (= 5 (+ 2 3))) ; -> 5
    (is (= 10 (+ 7 3)))) ; -> 10
  (testing "negative numbers"
    (is (= -5 (+ -2 -3))) ; -> -5
    (is (= -10 (+ -7 -3))))) ; -> -10
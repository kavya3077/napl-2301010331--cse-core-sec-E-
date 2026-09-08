package strop

func CountVowels(s string) int {
	count := 0

	for _, h := range s {
		if h == 'a' || h == 'e' || h == 'i' || h == 'o' || h == 'u' ||
			h == 'A' || h == 'E' || h == 'I' || h == 'O' || h == 'U' {
			count++
		}
	}

	return count
}

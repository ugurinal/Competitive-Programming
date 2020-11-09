from nltk.tokenize import sent_tokenize, word_tokenize
from nltk import MWETokenizer
text = "Malazgirt Meydan Muharebesi, 26 Ağustos 1071 tarihinde, Büyük Selçuklu Hükümdarı Alparslan ile Bizans İmparatoru Romen Diyojen arasında gerçekleşen muharebedir. Alparslan'ın zaferi ile sonuçlanan Malazgirt Muharebesi, \"Türklere Anadolu'nun kapılarında kesin zafer sağlayan son muharebe\" olarak bilinir."

print("\n")
print(text)
print("\n")
print(sent_tokenize(text))
print("\n")
print(word_tokenize(text))
print("\n")

mweTokenizer = MWETokenizer()

mweTokenizer.add_mwe(("Malazgirt Meydan Muharabesi"), ("Malazgirt Muharabesi"))

mweTokenizer.tokenize(text)


from sklearn.naive_bayes import CategoricalNB
from sklearn.preprocessing import OrdinalEncoder, LabelEncoder

X = [
    ["Sunny", "Hot"],
    ["Sunny", "Cold"],
    ["Rainy", "Hot"],
    ["Rainy", "Cold"],
    ["Overcast", "Hot"],
    ["Overcast", "Cold"]
]
y = ["No", "No", "Yes", "Yes", "Yes", "Yes"]

enc = OrdinalEncoder()
X = enc.fit_transform(X).astype(int)
le = LabelEncoder()
y = le.fit_transform(y)

model = CategoricalNB()
model.fit(X, y)

test = enc.transform([["Sunny", "Hot"]]).astype(int)
print("Prediction:", le.inverse_transform(model.predict(test))[0])

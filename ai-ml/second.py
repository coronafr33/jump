# K-Nearest Neighbors (kNN) Classifier

from sklearn.datasets import load_iris
from sklearn.model_selection import train_test_split
from sklearn.preprocessing import StandardScaler
from sklearn.neighbors import KNeighborsClassifier
from sklearn.metrics import accuracy_score, classification_report

iris = load_iris()
X = iris.data
y = iris.target


X_train, X_test, y_train, y_test = train_test_split(
    X, y, test_size=0.2, random_state=42, stratify=y
)


scaler = StandardScaler()
X_train = scaler.fit_transform(X_train)
X_test = scaler.transform(X_test)


model = KNeighborsClassifier(n_neighbors=5)

# Step 5: Train the model
model.fit(X_train, y_train)

# Step 6: Predict the test data
y_pred = model.predict(X_test)

# Step 7: Evaluate the model
print("Accuracy:", round(accuracy_score(y_test, y_pred) * 100, 2), "%")
print("\nClassification Report:")
print(classification_report(
    y_test, y_pred, target_names=iris.target_names
))

# Step 8: Predict a new flower
new_flower = [[5.1, 3.5, 1.4, 0.2]]
new_flower_scaled = scaler.transform(new_flower)

prediction = model.predict(new_flower_scaled)

print("New Flower Prediction:", iris.target_names[prediction[0]])
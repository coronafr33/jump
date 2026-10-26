import tensorflow as tf
import matplotlib.pyplot as plt
from sklearn.linear_model import LogisticRegression
from sklearn.metrics import accuracy_score, classification_report

(x_train, y_train), (x_test, y_test) = tf.keras.datasets.mnist.load_data()

y_train = (y_train == 0).astype(int)
y_test = (y_test == 0).astype(int)

x_train = x_train.reshape(-1,784)/255.0
x_test = x_test.reshape(-1,784)/255.0

model = LogisticRegression(max_iter=1000)
model.fit(x_train, y_train)
pred = model.predict(x_test)

print("Digit 0 vs Not digit")
print("Accuracy:", round(accuracy_score(y_test, pred) * 100, 2), "%")
print(classification_report(y_test,pred,
                            target_names=["Not Digit 0", "Digit 0"]))

for i in range (10):
    plt.subplot(2,5,i+ 1)
    plt.imshow(x_test[i].reshape(28 , 28), cmap="gray")
    plt.title("Digit 0" if pred[i] else "Not digit 0")
    plt.axis("off")

plt.tight_layout()
plt.show()
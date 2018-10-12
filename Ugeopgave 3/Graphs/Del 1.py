import matplotlib.pyplot as plt
import numpy as np
import math 

x = np.linspace(0, 2, 100)

plt.plot(x, math.log(3,3), label='quadratic')
# plt.plot(x, x**3, label='cubic')

plt.xlabel('x label')
plt.ylabel('y label')

plt.title("Simple Plot")

plt.legend()

plt.show()
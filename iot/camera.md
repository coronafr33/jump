Interface Pi Camera with Raspberry Pi to capture image and video

Aim; Interface Pi Camera with Raspberry Pi to capture image and video
Procedure ;  
Connect the finger print module to any one of the USB port of Raspi.
i) Install Python3 on Raspi.
command prompt:
sudo apt install idle3
sudo apt install python3-picamera2 -y
sudo apt install libcamera-apps -y
pip install opencv-python
pip install numpy
code; 
image code

from picamera2 import Picamera2
import time

picam2 = Picamera2()
picam2.start()
time.sleep(2)
picam2.capture_file("photo1.jpg")
print("Image Captured Successfully")
video code
from picamera2 import Picamera2
import time

picam2 = Picamera2()
picam2.start_and_record_video("video.mp4")
time.sleep(10)
picam2.stop_recording()
print("Video Saved")

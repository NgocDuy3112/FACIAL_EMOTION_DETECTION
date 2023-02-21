import cv2
import os

# construct super resolution model
sr = cv2.dnn_superres.DnnSuperResImpl_create()
path = "EDSR_x4.pb"
sr.readModel(path)
# set the model by passing the value and the upsampling ratio
sr.setModel("edsr", 4)

# get list of emotions
emos = os.listdir("D:/Data-Facial-Emotion/images/train")
# emos = ['disgust']

# create directory for each emotion if not existed
for emo in emos:
    if not os.path.exists(os.path.join("D:/Data-Facial-Emotion-upsized", emo)):
        os.makedirs(os.path.join("D:/Data-Facial-Emotion-upsized", emo))

# read image, upscale and copy to destination directory
for emo in emos:
    src = os.path.join("D:/Data-Facial-Emotion/images/train", emo)
    dst = os.path.join("D:/Data-Facial-Emotion-upsized", emo)
    IMAGE_FILES = os.listdir(src)
    for file in IMAGE_FILES:
        img = cv2.imread(os.path.join(src, file))
        result = sr.upsample(img)  # upscale the input image
        cv2.imwrite(os.path.join(dst, file), result)

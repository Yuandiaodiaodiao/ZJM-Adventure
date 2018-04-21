import os
import shutil
import time
shutil.copyfile("./webbuild/index.html","./webbuild2/index.html")
x=input()
with open("./webbuild2/index.html","r",encoding="UTF-8")as f:
    test=f.read()
a=test.find("横屏")
test=test[0:a]+"游戏版本"+str(x)+test[a:]
with open("./webbuild2/index.html","w",encoding="utf-8")as fb:
    #test = test.decode("utf8").encode("gbk")
    
    fb.write(test)
with open("./webbuild2/build/UnityLoader.js","r")as f:
    test=f.read()
a=test.find("UnityLoader.SystemInfo.hasWebGL")
print(a)
b=test.find("Blobs")
print(b)
print(test[a:b-2])

test=test[0:a]+" t() "+test[b-2:]

with open("./webbuild2/build/UnityLoader.js","w+")as fb:
    
    fb.write(test)
    pass

print("ojbk")
time.sleep(0.5)


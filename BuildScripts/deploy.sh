echo Clearning Up Build Directory
rm -rf ../TestProject/build/

echo Starting Build Process
'/c/Program Files/Unity/Editor/Unity.exe' -quit -bachmode -projectPath ../TestProject/ -executeMethod BuildScript.PerformBuild
echo Ended Build Process
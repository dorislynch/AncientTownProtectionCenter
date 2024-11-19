
# react-native-ancient-town-protection-center

## Getting started

`$ npm install react-native-ancient-town-protection-center --save`

### Mostly automatic installation

`$ react-native link react-native-ancient-town-protection-center`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-ancient-town-protection-center` and add `RNAncientTownProtectionCenter.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNAncientTownProtectionCenter.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNAncientTownProtectionCenterPackage;` to the imports at the top of the file
  - Add `new RNAncientTownProtectionCenterPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-ancient-town-protection-center'
  	project(':react-native-ancient-town-protection-center').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-ancient-town-protection-center/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-ancient-town-protection-center')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNAncientTownProtectionCenter.sln` in `node_modules/react-native-ancient-town-protection-center/windows/RNAncientTownProtectionCenter.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Ancient.Town.Protection.Center.RNAncientTownProtectionCenter;` to the usings at the top of the file
  - Add `new RNAncientTownProtectionCenterPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNAncientTownProtectionCenter from 'react-native-ancient-town-protection-center';

// TODO: What to do with the module?
RNAncientTownProtectionCenter;
```
  
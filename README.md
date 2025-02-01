# MauiGoogleAuth
### Google signin in Android:
 
**Pluging-**
Xamarin.GooglePayServices.Auth



**Google Cloud:**

[Firebase Console](https://console.firebase.google.com/) -> Create Project -> Build	-> Authentication Enable <br>
Go to Prject Setting -> App Section Select Android -> Provide below data <br>
* Android package name
* App nick name
* SHA1 fringerprint <br>

Authentication Enable -> Sing-in method -> Edit Google -> <br>
<img width="1456" alt="Screenshot 2025-02-01 at 8 18 29 PM" src="https://github.com/user-attachments/assets/6408162a-8e55-45c0-8240-7f09eb7ed007" />



Go Web SDK Configuration<br>
Get Web client ID
<img width="1451" alt="Screenshot 2025-02-01 at 8 16 08 PM" src="https://github.com/user-attachments/assets/9c082abf-a87e-4c7b-aa94-4408c26c2484" />


**SHA1:**

To get the SHA1 we need to execute the followin command in ternimal	

keytool -list -v -keystore “Full path of debug/release.keystore" -alias androiddebugkey -storepass android -keypass android<br>

**Note:**<br>
* debug.keystore path will work only for debug build
* release.keystore path will work for release build
  
**For Testing:**

bin-> android -> Open ternimal and execute followimg command

keytool -printcert -jarfile 'com.companyname.mauigoogleauth-Signed.apk'

# Output


https://github.com/user-attachments/assets/165df0ca-4b50-41bc-ba4e-f5fec9219923




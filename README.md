<div class="container">
	<h1>ADB Interceptor</h1>
	<p>Project requires C# and .NET Framework 6.0.</p>
	<p>ADB Interceptor is a tool designed to intercept and log commands and outputs of Android Debug Bridge (ADB) during the update process of Android devices. By replacing the 
		<code>adb.exe</code> file with this interceptor, you can monitor the background activities of your updating app. This can be particularly useful for developers and enthusiasts who want to understand what happens behind the scenes during the update process.
	</p>
	<h2>Installation</h2>
	<h3>Method 1: Compile from Source</h3>
	<ol>
		<li>
			<strong>Compile:</strong> Compile the source code.
		</li>
		<li>
			<strong>Rename Files:</strong>
			<ul>
				<li>Rename 
					<code>adb.exe</code> to 
					<code>adbGround.exe</code>.
				</li>
				<li>Rename 
					<code>adbmiddleware.exe</code> to 
					<code>adb.exe</code>.
				</li>
				<li>Place both 
					<code>adbGround.exe</code> and the newly renamed 
					<code>adb.exe</code> in the same folder.
				</li>
			</ul>
		</li>
		<li>
			<strong>Restart Update Program:</strong> Restart the Android update program you are using. ADB Interceptor will now log commands and outputs.
		</li>
	</ol>
	<h3>Method 2: Using Release Version</h3>
	<ol>
		<li>
			<strong>Download:</strong> Download the release version as a .zip file.
		</li>
		<li>
			<strong>Unzip:</strong> Unzip the archive.
		</li>
		<li>
			<strong>Replace Files:</strong> Replace all files with the respective ones you need in your project or application.
		</li>
	</ol>
	<h2>How It Works</h2>
	<p>ADB Interceptor works by intercepting and logging the ADB commands and outputs while an Android device is being updated. The tool replaces the original 
		<code>adb.exe</code> file with 
		<code>adbGround.exe</code> and the interceptor 
		<code>adbmiddleware.exe</code> with 
		<code>adb.exe</code>. This configuration enables ADB Interceptor to capture and log the activities of the updating app in the background.
	</p>
	<h2>Compatibility</h2>
	<ul>
		<li>
			<strong>Language:</strong> C#
		</li>
		<li>
			<strong>Framework:</strong> .NET Framework 6.0
		</li>
	</ul>
	<h2>Contributing</h2>
	<p>Feel free to contribute to this project by forking the repository and creating a pull request. Your contributions are always welcome!</p>
	<h2>License</h2>
	<p>This project is licensed under the 
		<a href="LICENSE.md">MIT License</a> - see the 
		<a href="LICENSE.md">LICENSE.md</a> file for details.
	</p>
	<p>
		<em>Note: ADB Interceptor is a tool created for educational and informational purposes. Please use it responsibly and comply with all applicable laws and regulations while using this tool.</em>
	</p>
	<p>
		<strong>Happy coding!</strong> 🚀
	</p>
</div>

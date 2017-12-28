# configs.cs

Read and Write various kinds of configuration files.


Capabilities

 * MySQL Configurations
 * FTP
 * User
 * API Keys
 * Software ID

Each kind of configuration has its own set of fields. For example, a MySQLL Database configuration has:

 * Host Name
 * Port Number
 * User Name
 * Password
 * Database Name

Structures of configuration files may be different for different purposes.


## Encoding

To prevent configurations beign edited manually, the files can be encoded with base64 like encoders.
It is optional.


## Dependencies

 * [hashing.cs](https://github.com/anytizer/hashing.cs)
 * [NewtonSoft Json.NET](https://www.newtonsoft.com/json)

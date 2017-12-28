# configs.cs

Read and Write various kinds of configuration files.


Current capabilities include:

 * MySQL Configurations
 * FTP
 * User
 * API Keys
 * Software ID

Each kind of configuration has its own set of fields. Examples:

| MySQL Database  | FTP Connection | User       |
| --------------- | -------------- | ---------- |
| Host Name       | Host           | User Name  |
| Port Number     | Port           | Password   |
| User Name       | User Name      |            |
| Password        | Password       |            |
| Database Name   | Path           |            |

Structures of configuration files may be different for different purposes.


## Encoding

To prevent configuration files being edited manually, you can encode them with base64 like encoders.
It is an optional step. Do not encode/decode files in the Reader/Writer. [Example](configs.classes/readerwriter/rw_mysql.cs).


## Dependencies

 * [hashing.cs](https://github.com/anytizer/hashing.cs)
 * [NewtonSoft Json.NET](https://www.newtonsoft.com/json)

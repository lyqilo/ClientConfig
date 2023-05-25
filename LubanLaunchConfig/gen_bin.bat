set GEN_CLIENT=dotnet Luban.ClientServer\Luban.ClientServer.dll

%GEN_CLIENT% -j cfg --^
 -d Defines\__root__.xml ^
 --input_data_dir Datas ^
 --output_data_dir Config ^
 --output_code_dir Gen ^
 --gen_types code_cs_unity_bin,data_bin ^
 -s all
pause
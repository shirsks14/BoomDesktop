filename = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
[f1,Fs_1] = audioread(filename{1});
[d1,Fs_2] = audioread(filename{2});
[n1,Fs_3] = audioread(filename{3});
[n2,Fs_4] = audioread(filename{4});
[n3,Fs_5] = audioread(filename{5});

hold all;

data = f1;
fs = Fs_1;
plot_single_wav( data, fs );

data = d1;
fs = Fs_2;
plot_single_wav( data, fs );

data = n1;
fs = Fs_3;
plot_single_wav( data, fs );

data = n2;
fs = Fs_4;
plot_single_wav( data, fs );

data = n3;
fs = Fs_5;
plot_single_wav( data, fs );

title('Sonic Boom Wav File Comparison');
legend('toggle');
legend(filename{1},filename{2},filename{3},filename{4},filename{5});
hold off;

%sound(data, fs);


% my_player = audioplayer(data, fs);
% play(my_player)

% dataInDB = mag2db(data); DOESN'T WORK
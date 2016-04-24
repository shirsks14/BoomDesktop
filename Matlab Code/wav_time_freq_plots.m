filename = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
[f1,Fs_1] = audioread(filename{1});
[d1,Fs_2] = audioread(filename{2});
[n1,Fs_3] = audioread(filename{3});
[n2,Fs_4] = audioread(filename{4});
[n3,Fs_5] = audioread(filename{5});

hold all;

fourier_transform( filename{1} );
fourier_transform( filename{2} );
fourier_transform( filename{3} );
%fourier_transform( filename{4} );
%fourier_transform( filename{5} );

hold off;
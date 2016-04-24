function fourier_transform( filename)
%Fourier Transform of Sound File

%Load Files
[y,Fs] = audioread(filename);

Nsamps = length(y);
t = (1/Fs)*(1:Nsamps);          %Prepare time data for plot

%Do Fourier Transform
y_fft = abs(fft(y));            %Retain Magnitude
y_fft = y_fft(1:Nsamps);      %Discard Half of Points
f = Fs*(0:Nsamps-1)/Nsamps;   %Prepare freq data for plot

%Plot Sound File in Time Domain
figure
plot(t, y')
xlabel('Time (s)')
ylabel('Amplitude')
title(strcat(filename,' in Time Domain'))

%Plot Sound File in Frequency Domain
figure
semilogx(f', 20*log10(y_fft))
xlim([0 1000])
xlabel('Frequency (Hz)')
ylabel('Amplitude')
title(strcat('Frequency Response of ', filename))
end
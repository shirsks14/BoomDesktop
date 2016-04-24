function [P, rms] = fouriertransform(fileName, plotCheck)
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
%   Sound Analysis with MATLAB Implementation    %
%                                                %
% Author: M.Sc. Eng. Hristo Zhivomirov  04/01/14 %
%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

% get a section of the sound file
[x,fs] = audioread(fileName);
x = x(:,1);             % get the first channel
xmax = max(abs(x));     % find the maximum value
% x = x/xmax;             % scalling the signal
temp = find(x);
x = x(temp(1)-1:temp(length(temp)));
x(length(x)+1) = 0;

% time & discretisation parameters
N = length(x);
t = (0:N-1)/fs;       

% plotting of the waveform
% figure(1)
% plot(t, x, 'r')
% xlim([0 max(t)])
% ylim([-1.1*max(abs(x)) 1.1*max(abs(x))])
% grid on
% set(gca, 'FontName', 'Times New Roman', 'FontSize', 14)
% xlabel('Time, s')
% ylabel('Normalized amplitude')
% title('The signal in the time domain')

% plotting of the spectrogram
% figure(2)
% spectrogram(x, 1024, 3/4*1024, [], fs, 'yaxis')
% h = colorbar;
% set(h, 'FontName', 'Times New Roman', 'FontSize', 14)
% ylabel(h, 'Magnitude, dB');
% set(gca, 'FontName', 'Times New Roman', 'FontSize', 14)
% xlabel('Time, s')
% ylabel('Frequency, Hz')
% title('Spectrogram of the signal')

% spectral analysis
win = hanning(N);       % window
K = sum(win)/N;         % coherent amplification of the window
X = abs(fft(x.*win)); % FFT of the windowed signal
P = max(X);
X = X;
NUP = ceil((N+1)/2);    % calculate the number of unique points
X = X(1:NUP);           % FFT is symmetric, throw away second half 
if rem(N, 2)            % odd nfft excludes Nyquist point
  X(2:end) = X(2:end)*2;
else                    % even nfft includes Nyquist point
  X(2:end-1) = X(2:end-1)*2;
end
f = (0:NUP-1)*fs/N;     % frequency vector
X = 20*log10(X);        % spectrum magnitude

if (plotCheck)
%Plot Sound File in Time Domain
figure
subplot(2,1,1);
plot(t, x);
xlabel('Time (s)')
ylabel('Amplitude')
title('Time Response');

%Plot Sound File in Frequency Domain
subplot(2,1,2);
semilogx(f, X);
xlim([0 1000])
xlabel('Frequency (Hz)')
ylabel('Amplitude (dB)')
title('Frequency Response')
end
% plotting of the spectrum
% figure(3)
% semilogx(f, X, 'r')
% xlim([0 max(f)])
% grid on
% set(gca, 'FontName', 'Times New Roman', 'FontSize', 14)
% title('Amplitude spectrum of the signal')
% xlabel('Frequency, Hz')
% ylabel('Magnitude, dB')

% plotting of the histogram
% figure(4)
% histfit(x)
% xlim([-1.1*max(abs(x)) 1.1*max(abs(x))])
% grid on
% set(gca, 'FontName', 'Times New Roman', 'FontSize', 14)
% xlabel('Signal amplitude')
% ylabel('Number of samples')
% title('Probability distribution of the signal')
% set(gca, 'FontName', 'Times New Roman', 'FontSize', 14)
% legend('probability distribution of the signal', 'standard normal distribution')

% computing of the autocorrelation
[Rx, lags] = xcorr(x, 'coeff');
d = lags/fs;

% plotting of the autocorrelation
% figure(5)
% plot(d, Rx, 'r')
% grid on
% xlim([-max(d) max(d)])
% set(gca, 'FontName', 'Times New Roman', 'FontSize', 14)
% xlabel('Delay, s')
% ylabel('Autocorrelation')
% title('Autocorrelation of the signal')
% line([-max(abs(d)) max(abs(d))], [0.02 0.02], 'Color', 'k', 'LineWidth', 2, 'LineStyle', '--');

% Sigma and Mu estimation
[u s] = normfit(x);
sigma = num2str(s);
mu = num2str(u);
% disp(['Sigma = ' sigma])
% disp(['Mu = ' mu])

% computing of the peak (crest) factor
rms = sqrt(mean(x.^2));
peak = max(abs(x));
Q = 20*log10(peak/rms);
Qstr = num2str(Q);
% disp(['Peak (crest) factor Q = ' Qstr ' dB'])

% computing of the dynamic range 
x(x==0) = [];
maxval = peak;
minval = min(abs(x));
D = 20*log10(maxval/minval);
Dstr = num2str(D);
% disp(['Dynamic range D = ' Dstr ' dB'])

% computing of the autocorrelation time
ind = find(Rx>0.02, 1, 'last');
RT = (ind-N)/fs;
RTstr = num2str(RT);
% disp(['Autocorrelation time = ' RTstr ' sec'])

end
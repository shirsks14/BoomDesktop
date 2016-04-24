function [Peak_amp, max_dist]= plotSound(fileName)
% filenames = {'f1.wav';'d1.wav';'n1.wav';'n2.wav';'n3.wav'};
% color = ['g'; 'b'; 'y';'m';'r'];

close all
% figure
% for i = 1:size(filenames)
    [temp,r_o,max_d] = dBWithDistance(fileName);
    
    figure
    xaxis = r_o:1:max_d;
    xaxis_1 = xaxis(1:45:length(xaxis));
    center = [0 0];
%     p = length(xaxis_1);
%         ColorSet = varycolor(length(xaxis_1));
    Y = Circle(xaxis_1,center,degtorad(45));
%   hold on
%   p = p-1;
    contour(xaxis_1,xaxis_1,Y);
    
    xlabel('Distance (Km)');
    ylabel('Distance (Km)');
    title('Sound Intensity Contour');
%     plot(xaxis,intarr, color(i));
    
%     hold on
% end
Peak_amp = max(temp);
max_dist = max_d;
end
   
% legend(filenames);
% plot(1:1:(max_d - r_o) +1,intarr);

% [Y,max_d] = soundint(468, P);
% olddB = 20*log10(P);
% newdB = 20*log10(Y);
% olddB
% newdB
% max_d